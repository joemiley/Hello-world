import pyautogui
from pyautogui import *
import time
import keyboard
import random
import win32api, win32con


pic = pyautogui.screenshot(region=(0, 0, 900, 900))

width, height = pic.size

# this means it will step through the image in 5 pixel increments. these steps can be any size
for x in range(0, width, 5):
    for y in range(0, height, 5):
        # saves the rgb values in an image
        r, g, b = pic.getpixel((x, y))

        if r == 255:
            print("then do a thing")
            click(x+550, y+550)
            time.sleep(0.05)
            break

        if b in range(180,210):
            print("then do another thing")
            click(x + 550, y + 550)
            time.sleep(0.05)
            break


