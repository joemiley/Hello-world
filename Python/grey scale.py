import os,cv2
path = r'C:\Users\Rando\Pictures\backgrounds' # Source Folder
dstpath = r'C:\Users\Rando\Pictures\backgrounds - Greyscale' # Destination Folder



try:
    makedirs(dstpath)
except:
    print ("Directory already exist, images will be written in same folder")

# Folder won't used
files = os.listdir(path)

for image in files:
    img = cv2.imread(os.path.join(path,image))
    gray = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
    cv2.imwrite(os.path.join(dstpath,image),gray)