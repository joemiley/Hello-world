import cv2
import os
import tensorflow as tf
import flaskpractice as FP
from os import listdir
from os.path import isfile, join


def machine_run():
    CATEGORIES = ["PNEUMONIA", "NORMAL"]

    FP.suc_upload_img_folder = os.path.join("static", "pics")
    FP.image_file_list = os.listdir(FP.suc_upload_img_folder)

    files_uploaded_list = [f for f in listdir(FP.suc_upload_img_folder)
                           if isfile(join(FP.suc_upload_img_folder, f))]

    unseen_data0 = FP.suc_upload_img_folder + "\\" + files_uploaded_list[0]

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
    inside_output0 = files_uploaded_list[0]
    inside_output1 = "Prediction:"
    inside_output2 = prediction
    inside_output3 = CATEGORIES[int(prediction[0][0])]
    output = f"{files_uploaded_list[0]} \nprediction: \n{prediction} \n{CATEGORIES[int(prediction[0][0])]}"
    print(output)

    return inside_output0, inside_output1, inside_output2, inside_output3

