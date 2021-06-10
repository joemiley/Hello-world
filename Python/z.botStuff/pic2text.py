import pyautogui
from PIL import Image
from pytesseract import *

pytesseract.tesseract_cmd = r'C:\Program Files\Tesseract-OCR\tesseract.exe'

image = Image.open("text.png")

output = pytesseract.image_to_string(image)

print(output)