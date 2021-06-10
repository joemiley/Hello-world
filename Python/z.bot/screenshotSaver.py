import pyautogui
from pyautogui import *
import time
import keyboard
import random
import win32api, win32con


# take a screen shot (region=(x,y,width,height))
X = 100
Y = 100
window_width = 500
window_height = 500
image = pyautogui.screenshot(region=(X, Y, window_width, window_height))
image.save(r'C:\Users\Rando\Desktop\coding\Hello-world\python\z.bot\image_0.png')