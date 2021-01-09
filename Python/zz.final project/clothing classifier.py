import tensorflow as tf
import numpy as np
import matplotlib.pyplot as plt

from tensorflow import keras

# loading in the data
fashion_mnist = keras.datasets.fashion_mnist
# where the database is:https://github.com/zalandoresearch/fashion-mnist

# loading the data into two sets of tuples "training tuple" and "test tuple"
# can i change the way these are around ie
# fashion_mnist.load_data() = (train_images, train_labels), (test_images, test_labels)?
# splits the data so that 60k were put into the training set and 10k were put into the test set as a default
(train_images, train_labels), (test_images, test_labels) = fashion_mnist.load_data()

# label classes:
# 0 = tshirt/top
# 1 = trousers
# 2 = pullover/jumper
# 3 = dress
# 4 = coat
# 5 = sandal
# 6 = shirt
# 7 = sneaker
# 8 = bag
# 9 = ankle boot
# this prints the label of the first picture which is a boot so should show 9
# print(train_labels[0])

# adding in a list of classification names
class_names = ['t-shirt/top', 'trouser', 'pullover', 'dress', 'coat', 'sandal', 'shirt', 'sneaker', 'bag', 'ankle boot']

# this gives how many elements there are and the size of each matrix
# print(train_images.shape)

# how many items there are
# print(len(train_images))

# labels that go along with every image (first is 9, second is 0, third is 0 and the end image has a label of 5
# print(train_labels)

# how many images are in the test set and their sizes (10000 images that are 28x28
# print(test_images.shape)

# this is like matlab where figure starts it,
# you pick an image to show,
# can show the colour bar if you like,
# whether you would like a grid overlay,
# then finally show it in a window
# plt.figure()
# plt.imshow(train_images[0])
# plt.colorbar()
# plt.grid(False)
# plt.show()

# this sets the images to black and white both training and testing sets
train_images = train_images / 255.0
test_images = test_images / 255.0

# showing them all in a grid with labels
# for i in range(0, 25):
#    plt.subplot(5, 5, i+1)
#    plt.xticks([])
#    plt.yticks([])
#    plt.grid(False)
#    plt.imshow(train_images[i], cmap=plt.cm.binary)
#    plt.xlabel(class_names[train_labels[i]])
# plt.show()

# creating the model
model = keras.Sequential([
    # flattening out the picture from 2 dimentions to one long one 1x(28x28)
    # or 1x784 matrix of numbers (a list with 784 entries)
    keras.layers.Flatten(input_shape=(28, 28)),
    # this means 128 nodes (neurons) in this layer (you can add more of these if needed for better results
    keras.layers.Dense(128, activation=tf.nn.relu),
    # this is the final node layer
    # this means it has 10 nodes for each of the classifications.
    # this gives 10 probability scores which will all add up to 1 because its a probability
    # each node will contain one of these scores 0-1
    # 10 comes from the classifications meaning each node at the end is one of the classifications (shoes jumper etx)
    # "softmax" is the final layer finisher
    keras.layers.Dense(10, activation=tf.nn.softmax),
    ])

# optimizer = how the model is updated as it sees the data (adam is just a common one used)
# loss = measures how accurate the model is (smaller the loss function the better the model)
# metrics = what we are looking at (want) from the model (monitor the training and testing steps)
# neural networks don't try to optimize accuracy they try to minimize loss

model.compile(optimizer="adam",
              loss="sparse_categorical_crossentropy",
              metrics=["accuracy"])

# feeding in the data and saying how many evolutions its going to take
model.fit(train_images, train_labels, epochs=5)

# asking it to save the values of loss and accuracy and printing it
# test_loss, test_acc = model.evaluate(test_images, test_labels)
# print("test accuracy", test_acc)

# creating a prediction function for an image that gives 10 prediction numbers for the classifications (highest wins)
predictions = model.predict(test_images)

# using the prediction function we made on the first image (gives out a list of 10 numbers)
print(predictions[0])

# grabs the highest prediction classification and shows it to us
# basically what the computer thinks it is
print(np.argmax(predictions[0]))
# and we check that prediction with the actual label of the image
print(test_labels[0])

# show which picture we are looking at for predictions
plt.figure()
plt.imshow(train_images[0])
plt.colorbar()
plt.grid(False)
plt.show()


