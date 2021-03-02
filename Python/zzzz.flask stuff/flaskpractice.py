from flask import Flask, render_template, url_for, request, redirect
import os
import glob
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
posts = [
    {
        'author': 'Joe Miley',
        'title': 'Patch post 1',
        'content': 'First post content',
        'date_posted': 'April 20, 2018'
    }
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
    return render_template('home.html', posts=posts)


# tab for about
@app.route("/about")
def about():
    return render_template('about.html', title='About')


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



