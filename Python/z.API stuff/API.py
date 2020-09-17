from tkinter import *
# from PIL import ImageTK,Image
import requests
import json


# from pprint import pprint

# create a tkinter object
root = Tk()
# the title of the window
root.title("Randombrooms weather app")
# where the icon is you would like to use for the window and its path location
root.iconbitmap("C:/Users/Rando/Desktop/coding/Hello-world/Python/images/weather.ico")
# size of the window
root.geometry("400x40")

# this gives london rather than cambridge because its the closest major city
# api.openweathermap.org/data/2.5/weather?q={city name}&appid={your api key}
# api.openweathermap.org/data/2.5/weather?q=Cambridge&appid=0a522e747cf87b0b6dd4e4808e66fc6a

# we'll try the longitude and latitude instead (longitude=52.2079 N,latitude 0.1417 E)
# api.openweathermap.org/data/2.5/weather?lat=0.1417&lon=52.2079&appid=0a522e747cf87b0b6dd4e4808e66fc6a

# then we add the unit specification so its easier to read
# http://api.openweathermap.org/data/2.5/weather?lat=0.1417&lon=52.2079&appid=0a522e747cf87b0b6dd4e4808e66fc6a&units=metric
# using a get request for the json information fro the url we generated
# will give you all the data from it in lists but in one big block
api_request = requests.get("http://api.openweathermap.org/data/2.5/weather?lat=0.1417&lon=52.2079&appid=0a522e747cf87b0b6dd4e4808e66fc6a&units=metric")

# this try will "try" to pull the information but if this doesn't work
# it'll throw an "Exception we call e. this way the api variable
# either contains the info we need or it contains error. then we just stick that
# into a label to print it and see what we get.
# api's can also return dictionaries so look at the data before trying to unpack it
# lists come in items which are identified by {}
try:
    api = json.loads(api_request.content)

except Exception as e:
    api = "Error . . . "

api_weather_description = (api["weather"][0]["main"])
celcius = (api["main"]["temp"])

description_label = Label(root, text="The weather in cambridge today is: " + str(api_weather_description),
                          font=("Courier", 11))

celcius_label = Label(root, text="and it is " + str(celcius) + "`C", font=("Courier", 11))

# pack just puts the text inside the label
description_label.pack()
celcius_label.pack()


# this is the show method at the end so it shows any information built before this point
root.mainloop()



