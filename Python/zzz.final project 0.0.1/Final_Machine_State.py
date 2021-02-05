from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten
from tensorflow.keras.layers import Conv2D, MaxPooling2D
from tensorflow.keras.callbacks import TensorBoard
import numpy as np
import pickle
import time

pickle_in = open("images(X).pickle", "rb")
X = pickle.load(pickle_in)

pickle_in = open("labels(y).pickle", "rb")
y = pickle.load(pickle_in)

X = np.array(X / 255.0)
y = np.array(y)



model = Sequential()

model.add(Conv2D(128, (3, 3), input_shape=X.shape[1:]))
model.add(Activation('relu'))
model.add(MaxPooling2D(pool_size=(2, 2)))

model.add(Flatten())

model.add(Dense(2))
model.add(Activation('softmax'))


model.compile(loss='sparse_categorical_crossentropy',
              optimizer='adam',
              metrics=['accuracy'],
              )
# print(model.summary())

model.fit(X, y,
          batch_size=32,
          epochs=10,
          validation_split=0.3,
          )


predictions = model.predict(X)
wrong_guesses = 0

for i in range(0, len(X)):
    if y[i] != np.argmax(predictions[i]):
        print(f"label{y[i]} | {np.argmax(predictions[i])} guess")
        wrong_guesses = wrong_guesses+1

percent_accuracy = (100/len(X))*(len(X)-wrong_guesses)
print(f"{wrong_guesses} out of {len(X)} incorrect")
print(f"accuracy {percent_accuracy}%")



