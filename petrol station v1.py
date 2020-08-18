import time
import random


timer_limit = 10
pump_name = ["pump 1", "pump 2", "pump 3", "pump 4", "pump 5", "pump 6", "pump 7", "pump 8", "pump 9"]
vehicle_at_pump = ["", "", "", "", "", "", "", "", ""]


class Vehicle:
    def __init__(self, tank_size, current_litres, no_of_seats, type_of_vehicle, vehicle_id):
        self.tank_size = tank_size
        self.current_litres = current_litres
        self.no_of_seats = no_of_seats
        self.type_of_vehicle = type_of_vehicle
        self.vehicle_id = vehicle_id


no_of_vehicles = 9
vehicle_list = list()


while no_of_vehicles > 0:
    _vehicle_id = random.randint(1000, 9999)
    _tank_size = random.randint(30, 51)
    _current_litres = random.randint(10, _tank_size)
    _number_of_seats = random.randint(2, 5)
    if _number_of_seats == 2:
        _type_of_vehicle = "hgv"
    elif _number_of_seats == 3:
        _type_of_vehicle = "van"
    elif _number_of_seats > 3:
        _type_of_vehicle = "car"

    created_vehicle = Vehicle(_tank_size, _current_litres, _number_of_seats, _type_of_vehicle, _vehicle_id)
    vehicle_list.insert(0, created_vehicle)
    no_of_vehicles -= 1

j = 1
number_counter = 0
while j != 0:

    time.sleep(2)

    if vehicle_at_pump[number_counter] == "":

        vehicle_at_pump[number_counter] = str(vehicle_list[number_counter].vehicle_id)


    print(pump_name[6] + ": " + vehicle_at_pump[6] + "          " + pump_name[3] + ": " + vehicle_at_pump[3] + "         " + pump_name[0] + ": " + vehicle_at_pump[0])
    print(pump_name[7] + ": " + vehicle_at_pump[7] + "          " + pump_name[4] + ": " + vehicle_at_pump[4] + "         " + pump_name[1] + ": " + vehicle_at_pump[1])
    print(pump_name[8] + ": " + vehicle_at_pump[8] + "          " + pump_name[5] + ": " + vehicle_at_pump[5] + "         " + pump_name[2] + ": " + vehicle_at_pump[2])

    for i in range(0, 1):
        print("")

    print("Forecourt queue:")

    for i in vehicle_list:
        print(f"vehicle id: {i.vehicle_id}    "
          f"type of vehicle: {i.type_of_vehicle}    "
          f"vehicle tank size: {i.tank_size}    "
          f"current litres: {i.current_litres}   "
          f"number of seats: {i.no_of_seats}")


    number_counter += 1
    if number_counter > 8:
        number_counter = 0

    for i in range(0, 1):
        print("")

