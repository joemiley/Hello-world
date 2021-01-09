import tensorflow as tf
import numpy as np
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten, Conv2D, MaxPooling2D
import pickle

# load in the data we have pre processed to the right sizes
X = pickle.load(open("X.pickle", "rb"))
y = pickle.load(open("y.pickle", "rb"))

# making the data to numpy arrays for tensor flow to use
X = np.array(X/255.0)
y = np.array(y)

# move through the model left to right please then go back round
model = Sequential()

# conv2d64 just means a 64 layer (neuron)
# (3,3) is just the sliding window size
# input_shape=X.shape[1:] just means its one layer of data
# we used relu before in the clothes one but it stands for rectify linear (its the standard default used one)
# all of this makes up 1 layer with 64 neurons
model.add(Conv2D(64, (3, 3), input_shape=X.shape[1:]))
model.add(Activation("relu"))
model.add(MaxPooling2D(pool_size=(2, 2)))

# second layer (you dont have to restate the shape of the data)
model.add(Conv2D(64, (3, 3)))
model.add(Activation("relu"))
model.add(MaxPooling2D(pool_size=(2, 2)))

# final layer
# flatten the data ready for the final dense layer
model.add(Flatten())
model.add(Dense(64))

# output layer
model.add(Dense(1))
model.add(Activation("sigmoid"))

# what the model is going to give us
model.compile(loss="binary_crossentropy",
              optimizer="adam",
              metrics=["accuracy"])

# how many you want to pass through the NN at once (we're going with 32 for now)
# validation split is using 10% of the data to check for results
# epochs is how many times the data goes through (evolutions)
model.fit(X, y, batch_size=32, epochs=3, validation_split=0.1)
