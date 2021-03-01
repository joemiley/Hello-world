import cv2
import tensorflow as tf
import os
from os import listdir
from os.path import isfile, join

CATEGORIES = ["NORMAL", "PNEUMONIA"]

files_uploaded_list = [f for f in listdir(r"C:\Users\Rando\Desktop\coding\Hello-world\python\zzzz.flask stuff\images_uploaded")
                       if isfile(join(r"C:\Users\Rando\Desktop\coding\Hello-world\python\zzzz.flask stuff\images_uploaded", f))]

unseen_data0 = r"C:\Users\Rando\Desktop\coding\Hello-world\python\zzzz.flask stuff\images_uploaded\\" + files_uploaded_list[0]


def prepare(filepath):
    IMG_SIZE = 150  # size we are reshaping the image to
    img_array = cv2.imread(filepath, cv2.IMREAD_GRAYSCALE)  # reading the image and converting to greyscale
    new_array = cv2.resize(img_array, (IMG_SIZE, IMG_SIZE))  # resizing the image
    return new_array.reshape(-1, IMG_SIZE, IMG_SIZE, 1)  # give the image in the new format
                                                         # that matches the preproccessed data


# loading in the model we tested and optimised for
model = tf.keras.models.load_model("Usable-128x1conv.model")

# getting it to load in our unseen image in the correct format (you have to pass in a list to predict)
prediction = model.predict([prepare(unseen_data0)])

# it has to take in the two catigories
print("prediction")
print(prediction)
print(CATEGORIES[int(prediction[0][0])])

