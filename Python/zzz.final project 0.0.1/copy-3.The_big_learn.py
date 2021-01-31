from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten
from tensorflow.keras.layers import Conv2D, MaxPooling2D
from tensorflow.keras.callbacks import TensorBoard
import numpy as np
import pickle
import time

pickle_in = open("X.pickle", "rb")
X = pickle.load(pickle_in)

pickle_in = open("y.pickle", "rb")
y = pickle.load(pickle_in)

X = np.array(X / 255.0)
y = np.array(y)

dense_layers = [0] # [0, 1, 2]
node_sizes = [128] # [32, 64, 128]
conv_layers = [1] # [1, 2, 3]

for dense_layer in dense_layers:
    for nodes in node_sizes:
        for conv_layer in conv_layers:
            NAME = "binary-act(sigmoid)-nodes{}-conLayer{}-denLayer{}-time{}".format(nodes, conv_layer, dense_layer, int(time.time()))
            print(NAME)

            model = Sequential()

            model.add(Conv2D(nodes, (3, 3), input_shape=X.shape[1:]))
            model.add(Activation('relu'))
            model.add(MaxPooling2D(pool_size=(2, 2)))

            for l in range(conv_layer-1):
                model.add(Conv2D(nodes, (3, 3)))
                model.add(Activation('relu'))
                model.add(MaxPooling2D(pool_size=(2, 2)))

            model.add(Flatten())

            for _ in range(dense_layer):
                model.add(Dense(nodes))
                model.add(Activation('relu'))

            model.add(Dense(1))
            model.add(Activation('sigmoid'))

            tensorboard = TensorBoard(log_dir="logs2/{}".format(NAME))

            model.compile(loss='binary_crossentropy',
                          optimizer='adam',
                          metrics=['accuracy'],
                          )

            model.fit(X, y,
                      batch_size=32,
                      epochs=10,
                      validation_split=0.3,
                      callbacks=[tensorboard])

# model.save(NAME+".model")


# how to use tensorboard in cmd:
# cd zzz.final project 0.0.1
# tensorboard --logdir=logs2