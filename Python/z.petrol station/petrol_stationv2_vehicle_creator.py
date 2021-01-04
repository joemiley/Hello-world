import random
import petrol_stationv2_lists as ps_lists


# vehicle class
class Vehicle:
    # defining what is in the class
    def __init__(self, tank_size, current_litres, no_of_seats, type_of_vehicle, vehicle_id):
        # defining where to get the information from
        self.tank_size = tank_size
        self.current_litres = current_litres
        self.no_of_seats = no_of_seats
        self.type_of_vehicle = type_of_vehicle
        self.vehicle_id = vehicle_id



