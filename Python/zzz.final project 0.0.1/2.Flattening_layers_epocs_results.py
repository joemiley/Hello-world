import tensorflow as tf
import numpy as np
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten, Conv2D, MaxPooling2D
import pickle
import matplotlib.pyplot as plt


# load in the data we have pre processed to the right sizes
X = pickle.load(open("images(X).pickle", "rb"))
y = pickle.load(open("labels(y).pickle", "rb"))

# making the data to numpy arrays for tensor flow to use
X = np.array(X / 255.0)
y = np.array(y)

amount_Of_Times_To_Run = input("how many different machines would you like? ")

for i in range(0, int(amount_Of_Times_To_Run)):
    # move through the model left to right please then go back round
    model = Sequential()

    # conv2d 64 just means a 64 layer (neuron)
    # (3,3) is just the sliding window size it uses
    # input_shape=X.shape[1:] just means its one layer of data in an array
    # we used relu before in the clothes one but it stands for rectify linear (its the standard default used one)
    # all of this makes up 1 layer with 64 neurons
    model.add(Conv2D(64, (3, 3), input_shape=X.shape[1:]))
    model.add(Activation("relu"))
    model.add(MaxPooling2D(pool_size=(2, 2)))

    # second layer (you dont have to restate the shape of the data as its already in that shape when it gets here)
    model.add(Conv2D(64, (3, 3)))
    model.add(Activation("relu"))
    model.add(MaxPooling2D(pool_size=(2, 2)))

    # final layer
    # flatten the data ready for the final dense layer
    model.add(Flatten())
    model.add(Dense(64))

    # output layer
    # have to use sigmoid instead of soft-max due to the max's being
    # well above acceptable limits (two options didn't add up to 1 meaning something was very off)
    # dense 2 just means that at the end they can fall into two classifications (normal or pneumonia)
    model.add(Dense(2))
    model.add(Activation("sigmoid"))

    # what the model is going to give us
    # sparse_categorical_crossentropy instead of binar-crossentropy due to there being more than one value
    model.compile(loss="sparse_categorical_crossentropy",
                  optimizer="adam",
                  metrics=["accuracy"])

    # batch_size = how many you want to pass through the NN at once (we're going with 32 for now)
    # epochs = how many times the data goes through (evolutions)
    # validation split is using 10% of the data to check for results per evolution
    model.fit(X, y, batch_size=64, epochs=1, validation_split=0.1)

    # this is where the predictions happen (i could feed new data here)
    predictions = model.predict(X)

    # counter for the guesses it gets wrong
    counter = 0
    # looking through all of them and seeing which once we got wrong and adding one to the counter
    for j in range(0, len(X)):
        if y[j] != np.argmax(predictions[j]):
            counter += 1
#            print(f"image{j}: actual label = {y[j]}     |"
#                  f"guess = {np.argmax(predictions[j])}     |"
#                  f"percentages = {predictions[j]}")


    # working out the percentage that are incorrect and printing
    wrong_percent = (100 / len(X)) * counter
    print(f"machine{i+1}||  "
          f"wrong counter: {counter} / {len(X)}    ||"
          f" this means that {wrong_percent:.4f}% are incorrect")





