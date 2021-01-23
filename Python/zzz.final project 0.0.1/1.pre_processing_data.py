import numpy as np
import matplotlib.pyplot as plt
import os
import cv2
import random
import pickle
import time

Timer_start = time.time()
# loading in the data
DATADIR = r"C:\Users\Rando\Desktop\final project\dataset_ML(using)"

# loading in the two categories (dogs = position 0, cats = position 1 in the list)
CATEGORIES = ["NORMAL", "PNEUMONIA"]

# normalising the data to a set size
# sizing using for the M and N
img_size = 150

# creating an empty list for the training data
training_data = []

# empty lists ready to be filled with [feature(image) = x   label(normal, pneumonia) = y]
images = []
label = []

# output message to the user
print(f"working on resizing data to {img_size}x{img_size}")


# creating the create_training_data method
def create_training_data():
    # for i in categories (2 entries)
    for category in CATEGORIES:
        # creates a path to both cats and dogs directory
        path = os.path.join(DATADIR, category)
        # 0=dog, 1 =cat for classification
        class_num = CATEGORIES.index(category)

        # for every image in the directory do this (0-however many images)
        for img in os.listdir(path):
            try:
                # adding to the array of images loaded in and greyscaling
                # them for less data (colour = 3x255, greyscale =1x255 data)
                img_array = cv2.imread(os.path.join(path, img), cv2.IMREAD_GRAYSCALE)  # converting to greyscale
                # resizing the array(picture)
                new_array = cv2.resize(img_array, (img_size, img_size))
                training_data.append([new_array, class_num])
            except Exception as e:
                pass


# using the above method
create_training_data()

# shuffling data so its not all cats or dogs first
random.shuffle(training_data)

# adding all the pictures to the X list and the labels to the y list
for features, Tags in training_data:
    images.append(features)
    label.append(Tags)

# reshaping all images in X to the variable img_size by img_size and giving it the one layer of data for greyscale
images = np.array(images).reshape(-1, img_size, img_size, 1)

# save the data made so you don't have to rebuild your training data
# saving X (imgs in the list of X)
pickle_out = open("images(X).pickle", "wb")
pickle.dump(images, pickle_out)
pickle_out.close()
# saving the list of y (labels)
pickle_out = open("labels(y).pickle", "wb")
pickle.dump(label, pickle_out)
pickle_out.close()

print(f"data resized to {img_size}x{img_size} and saved (images = images(X).pickle)(labels = labels(y).pickle)")
print(f"time taken to finish : {time.time()-Timer_start:.2f} s")


