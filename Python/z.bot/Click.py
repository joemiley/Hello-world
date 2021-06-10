import pyautogui
from pyautogui import *
import time
import keyboard
import random
import win32api, win32con

# we are going to look for black pixels
X = 0
Y = 0

colour_values = [0, 0, 0]   # red, green and blue


# this takes function takes an x and y then left clicks on it
def click(x, y):
    win32api.SetCursor((x, y))
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0)
    time.sleep(0.01)    # This pauses the script for 0.01 seconds or else the click is too fast
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0)


# runs the main code
while keyboard.is_pressed('q') == False:
    # the [0] is checking for the red value (1=Green and 2=Blue)
    # for a total colour then && could be used or it could be converted to greyscale
    if pyautogui.pixel(X, Y)[0] == colour_values[0]:
        # now to call the function created
        # this can now be coppied as many times as needed
        click(X, Y)



