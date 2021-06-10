import pyautogui
from pyautogui import *
import time
import keyboard
import random
import win32api, win32con



while True:
    # this allows the computer to check for the dog with a 80% confidence rating
    # if confidence is <80% it doesn't find it
    # this can also have greyscale for added speed after "confidence = 0.8"
    if pyautogui.locateOnScreen('dog.png', confidence= 0.8) != None:
        print("pybot can see it")
        time.sleep(0.5)
    else:
        print("pybot can not see it")
        time.sleep(0.5)