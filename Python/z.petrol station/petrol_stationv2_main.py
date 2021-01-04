import petrol_stationv2_lists as ps_lists
import petrol_stationv2_vehicle_creator as ps_vehicle_creator
import petrol_stationv2_graphics
import random
import time

# put all into a do loop on a second timer
while True:

    # create vehicles for the highway list
    while len(ps_lists.list_highway) < 2:
        _vehicle_id = random.randint(1000, 9999)
        _tank_size = random.randint(30, 51)
        _current_litres = random.randint(10, _tank_size-5)
        _number_of_seats = random.randint(2, 5)
        if _number_of_seats == 2:
            _type_of_vehicle = "hgv"
        elif _number_of_seats == 3:
            _type_of_vehicle = "van"
        elif _number_of_seats > 3:
            _type_of_vehicle = "car"

        # created vehicle goes into the highway list at position 0 and 1
        created_vehicle = ps_vehicle_creator.Vehicle(_tank_size, _current_litres, _number_of_seats, _type_of_vehicle,
                                                     _vehicle_id)
        ps_lists.list_highway.append(created_vehicle)
        print(f"created vehicle: {created_vehicle.vehicle_id}")

    # adding the vehicle from highway to the queue into the petrol station
    for i in range(0, len(ps_lists.list_highway)):
        if len(ps_lists.list_queue_into_petrol_station) < 5:
            ps_lists.list_queue_into_petrol_station.append(ps_lists.list_highway.pop(0))
            print(f"vehicle {i} in queue: {ps_lists.list_queue_into_petrol_station[i].vehicle_id}")

    # check for availability of a pump
    for i in range(len(ps_lists.list_pump_is_available)):
        # checking if there is a vehicle in the position
        if ps_lists.list_queue_into_petrol_station:
            # checking if that position is available
            if ps_lists.list_pump_is_available[i]:
                # inserting the vehicle from the queue
                ps_lists.list_vehicle_at_pump[i] = ps_lists.list_queue_into_petrol_station.pop(0)
                ps_lists.list_pump_is_available[i] = False
                print(f"vehicle at pump {i+1}: {ps_lists.list_vehicle_at_pump[i].vehicle_id}")

    for i in range(0, len(ps_lists.list_vehicle_at_pump)):
        if ps_lists.list_vehicle_at_pump[i]:
            ps_lists.list_finished_vehicles.insert(0, ps_lists.list_vehicle_at_pump[i])
            ps_lists.list_vehicle_at_pump[i] = None
            ps_lists.list_pump_is_available[i] = True
            print(f"vehicle finished: {ps_lists.list_finished_vehicles[0].vehicle_id}")

    print("")

#    vehicle_move_x = 10
#    vehicle_move_y = 640
#    if vehicle_move_x > 850:
#        vehicle_move_x += -180
#        vehicle_move_y = 740
#    elif vehicle_move_x < 0:
#        vehicle_move_x = 10
#    else:
#        vehicle_move_x += 180

    time.sleep(10)
