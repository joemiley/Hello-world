import pyautogui
import time
import keyboard
import win32api
import win32con
from PIL import Image
from pytesseract import *

pytesseract.tesseract_cmd = r'C:\Program Files\Tesseract-OCR\tesseract.exe'


# the click function
def click(x, y):
    win32api.SetCursor((x, y))
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, 0, 0)
    time.sleep(0.01)    # This pauses the script for 0.01 seconds or else the click is too fast
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, 0, 0)


# keypress
def key_press(key):
    keyboard.KEY_DOWN(str(key))
    time.sleep(0.01)
    keyboard.KEY_UP(str(key))


# pause function
def pause(time_to_pause):
    time.sleep(time_to_pause)


# screen shot function
def screenshot(x, y, width, height):
    image_counter = 0
    image = pyautogui.screenshot(region=(x, y, width, height))
    image.save(r'.\image_'+str(image_counter)+'.png')
    if image_counter > 9:
        image_counter == 0
    else:
        image_counter += 1


# image recognition (requires the extension inside the file name)
def image_recognition(image_file_name, confidence_percent):
    if pyautogui.locateOnScreen(str(image_file_name), confidence= confidence_percent) != None:
        print("pybot can see it")
        time.sleep(0.5)
    else:
        print("pybot can not see it")
        time.sleep(0.5)


def pic2text(image_file_name):
    image = Image.open(str(image_file_name))
    output = pytesseract.image_to_string(image)
    print(output)








