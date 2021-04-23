from flask import Flask, render_template, url_for, request, redirect
import os
from os import listdir
from os.path import isfile, join
from werkzeug.utils import secure_filename

app = Flask(__name__)

suc_upload_img_folder = os.path.join("static", "pics")
image_file_list = os.listdir(suc_upload_img_folder)
# config files:

# relates to allowed_image method for file extensions
app.config["ALLOWED_IMAGE_EXTENSIONS"] = ["PNG", "JPG", "JPEG", "GIF"]
# relates to the upload images tab (saves in files_uploaded\pics\...)
# relates to the upload images tab (saves in static\pics\...)
app.config["IMAGE_UPLOAD"] = suc_upload_img_folder
# relates to successful upload tab
app.config["UPLOAD_FOLDER"] = suc_upload_img_folder

# this is the list of patch notes. just a normal list so add a , and write a new post
patches = [
    {
        'author': 'Joe Miley',
        'title': 'Patch post 1',
        'content': 'First post content and git commands file added',
        'date_posted': 'Tue Aug 18 12:34:33'
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 2',
        'content': 'git commands file updated',
        'date_posted': 'Tue Aug 18 12:38:02 2020 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 3',
        'content': 'broke Git and trying to fix along with the start of CNN research',
        'date_posted': 'Mon Sep 14 14:23:38 2020 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 4',
        'content': 'fixed Git and continued CNN research (see zz.final project practice and random learning)',
        'date_posted': 'Thu Sep 17 14:18:28 2020  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 5',
        'content': 'all previous code from old laptop and pull to new laptop (broke)',
        'date_posted': 'Sat Sep 19 21:10:04 2020  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 6',
        'content': 'all previous code from old laptop and pull to new laptop (fixed)',
        'date_posted': 'Sun Sep 20 10:10:04 2020  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 7',
        'content': 'new ML projects in python file (broke file size)',
        'date_posted': 'Sat Jan 9 12:21:01 2021  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 8',
        'content': 'added .pickle files to git.ignore (fixed)',
        'date_posted': 'Sat Jan 9 12:25:30 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 9',
        'content': 'user input added and multi machine for ML is running along with size modifier file',
        'date_posted': 'Fri Jan 15 01:49:20 2021  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 10',
        'content': "got the ML printing the wrong numbers and there is a problem where it doesn't always pick the "
                   "option with the highest % so thats next",
        'date_posted': 'Sat Jan 23 18:26:39 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 11',
        'content': "trying new ML copies files are attached",
        'date_posted': 'Mon Jan 25 21:28:01 2021  '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 12',
        'content': "in-case laptop crashed through lack of memory when running optimizer "
                   "here are all the machine metrics saved to the repo",
        'date_posted': 'Wed Jan 27 19:47:30 2021   '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 13',
        'content': "it didnt crash but 13/16gb of ram used. "
                   "all 27 states of my machine saved and can be shown in Tensorflow",
        'date_posted': 'Wed Jan 27 23:55:49 2021'
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 14',
        'content': "ran the binary version of the ML with no avail"
                   "(still the validation sits at 71% even when good old softmax is used) most upsetting",
        'date_posted': 'Sat Jan 30 14:14:49 2021'
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 15',
        'content': " started to build user front end to load data into",
        'date_posted': 'Sun Jan 31 21:20:16 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 16',
        'content': " prediction images are now in and it seems to predict right from testing on "
                   "unseen data. the unseen data images are from google image searches and stored as an image "
                   "in completely different "
                   "directories from the main app so no previous bias is used, current test is with 4 unseen images"
                   " in various places with vairous names.",
        'date_posted': 'Mon Feb 1 02:16:01 2021'
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 17',
        'content': "started on frontend of the ML project. so far able to create html files,"
                   " load them in and show them on different pages",
        'date_posted': 'Wed Feb 3 15:53:42 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 18',
        'content': "added a piece to show my ml setting for the avg % correct (not front end just for my own view)"
                   ". comes out at 99.25% with the open source"
                   " kaggle database it was built on and this seems to work well for images pulled off google image"
                   " search",
        'date_posted': 'Fri Feb 5 00:57:04 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 19',
        'content': "usable machine now loads the image from the 'static' directory! :D",
        'date_posted': 'Mon Mar 1 16:59:19 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 20',
        'content': "added a function which checks the file being uploaded. Time to fill the html with text",
        'date_posted': 'Tue Mar 2 15:28:44 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 21',
        'content': "written assingment based work will now take centre stage due to it being week 7/12",
        'date_posted': 'Tue Mar 2 15:28:44 2021 '
    },
    {
        'author': 'Joe Miley',
        'title': 'Patch post 22',
        'content': "redirects and file 'flow' are now complete to guide the user around in a circle."
                   "wish i was able to change the upload to change to the image name however it seems that"
                   " it would take me learning some JS and sadly i am out of time so this is the final state"
                   "of the project until after i finish university",
        'date_posted': 'Tue Mar 11 01:18:54 2021 '
    },
]


def allowed_image(filename):
    if not "." in filename:
        return False
    ext = filename.rsplit(".", 1)[1]

    if ext.upper() in app.config["ALLOWED_IMAGE_EXTENSIONS"]:
        return True
    else:
        return False


# tab for home
@app.route("/")
@app.route("/home")
def home():
    return render_template('home.html', title='HomePage')


# tab for about
@app.route("/about")
def about():
    return render_template('about.html', title='About', patches=patches)


# tab for uploading images
@app.route("/upload-image", methods=['GET', 'POST'])
def upload_image():
    if request.method == "POST":

        if request.files:
            image = request.files["image"]

            if request.files:
                image = request.files["image"]
                if image.filename == "":
                    return redirect('upload-image')

                if not allowed_image(image.filename):
                    print("that image extension is not accepted")
                    return redirect('about')


                else:
                    filename = secure_filename(image.filename)
            image.save(os.path.join(app.config["IMAGE_UPLOAD"], filename))
            print("image.saved")
            print(image)

            return redirect('successful_upload')

    return render_template('upload.html', title='upload image', len=len(image_file_list), image_file_list=image_file_list)


# tab for successful upload
@app.route("/successful_upload")
def successful_upload():
    files_uploaded_list = [f for f in listdir(suc_upload_img_folder)
                           if isfile(join(suc_upload_img_folder, f))]
    pic1 = os.path.join(app.config["UPLOAD_FOLDER"], files_uploaded_list[0])
    return render_template('successful_upload.html', title='successful_upload', user_image=pic1)


@app.route("/output")
def output():
    import Usable_machine as machine
    inside_output0, inside_output1, inside_output2, inside_output3 = machine.machine_run()
    files_uploaded_list = [f for f in listdir(suc_upload_img_folder)
                           if isfile(join(suc_upload_img_folder, f))]
    pic1 = os.path.join(app.config["UPLOAD_FOLDER"], files_uploaded_list[0])
    return render_template('output.html',
                           output0=inside_output0,
                           output1=inside_output1,
                           output2=inside_output2,
                           output3=inside_output3, pic1=pic1)


@app.route("/returning_home")
def returning_home():
    files_uploaded_list = [f for f in listdir(suc_upload_img_folder)
                           if isfile(join(suc_upload_img_folder, f))]
    for i in range(0, len(files_uploaded_list)):
        os.remove(suc_upload_img_folder+"\\"+files_uploaded_list[i])

    return redirect('home')


if __name__ == '__main__':
    app.run(debug=True)



