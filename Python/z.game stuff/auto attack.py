from pynput.keyboard import Key, Controller
import time
import random

keyboard = Controller()

key_one = 'q'
key_two = '4'

time.sleep(5)

for i in range(0, 1000):
    keyboard.press('q')
    keyboard.release('q')
    time.sleep(random.uniform(0.1, 0.3))
    keyboard.press(key_two)
    keyboard.release(key_two)
    time.sleep(random.uniform(0.1, 0.3))


