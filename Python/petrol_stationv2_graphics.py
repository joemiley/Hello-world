from tkinter import *
import time
import petrol_stationv2_lists as ps_list
import petrol_stationv2_main as ps_main

root = Tk()

# title of the window
root.title("Randombrooms Petrol Station")

# create the size of the window
root.geometry("800x800+10+20")

# create a button
# button1 = Button(root, text="this is a button", fg="grey")

# create a text field (bd is the bevelled boarder)
# textfield = Entry(root, text="this is for text entry", bd=5)

highway_graphic = Frame(root, width=800, height=200, background="grey")
highway_graphic.place(x=0, y=600)

for i in range(0, 8):
    road_line = Frame(root, width=50, height=5, background="white")
    road_line.place(x=i*100, y=700)

queue_into_petrol_station1 = Frame(root, width=200, height=150, background="grey")
queue_into_petrol_station2 = Frame(root, width=200, height=150, background="grey")
queue_into_petrol_station1.place(x=30, y=440)
queue_into_petrol_station2.place(x=570, y=440)

petrol_station_graphic = Frame(root, width=740, height=370, highlightbackground="black", highlightthickness=2)
petrol_station_graphic.place(x=30, y=60)


pump_box_y_pos = 80
for i in range(0, 3):
    for j in range(1, 15, 5):
        pump_graphic_box = Frame(root, width=100, height=30, highlightbackground="black", highlightthickness=2)
        pump_graphic_box.place(x=j*58, y=pump_box_y_pos)
    pump_box_y_pos += 120


# how to create a label
title_label = Label(root, text="Petrol Station", font="arial 30")
title_label.pack()


pump_label_xpos = 660
pump_label_ypos = 82
for i in range(1, 10):
    pump_label = Label(root, text=f"Pump {i}", font="arial 12")
    pump_label.place(x=pump_label_xpos, y=pump_label_ypos)
    pump_label_xpos -= 290
    if i == 3:
        pump_label_ypos += 120
    if i == 6:
        pump_label_ypos += 120
    if pump_label_xpos < 79:
        pump_label_xpos = 660

highway_label = Label(root, text="Highway", font="arial 12", background="grey", fg="white")
highway_label.place(x=360, y=600)

queue_label = Label(root, text="Queue", font="arial 12", background="grey", fg="white")
queue_label.place(x=100, y=440)

finished_label = Label(root, text="finished", font="arial 12", background="grey", fg="white")
finished_label.place(x=645, y=440)


pump_vehicle_xpos = 635
pump_vehicle_ypos = 110
for i in range(0, 9):
    pump_vehicle = Label(root, text=f"vehicle {i}", font="arial 10")
    pump_vehicle.place(x=pump_vehicle_xpos, y=pump_vehicle_ypos)
    pump_vehicle_xpos -= 290
    if i == 2:
        pump_vehicle_ypos += 120
        pump_vehicle_xpos = 635
    if i == 5:
        pump_vehicle_ypos += 120
        pump_vehicle_xpos = 635
    if pump_label_xpos < 79:
        pump_vehicle_xpos = 660

queue_xpos = 45
queue_ypos = 461
for i in range(0, 5):
    queue_list = Label(root, text=f"vehicle{i}", font="arial 10")
    queue_list.place(x=queue_xpos, y=queue_ypos)
    queue_ypos += 24

finished_list_xpos = 587
finished_list_ypos = 461
for i in range(0, 5):
    finished_list = Label(root, text=f"vehicle{i}", font="arial 10")
    finished_list.place(x=finished_list_xpos, y=finished_list_ypos)
    finished_list_ypos += 24


# highway_vehicles = Label(root, text="vehicle_id", font="arial 10", bg="cyan")
# highway_vehicles.place(x=ps_main.vehicle_move_x, y=ps_main.vehicle_move_y)



root.mainloop()


