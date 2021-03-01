from flask import Flask, render_template, url_for, request, redirect
import os
import pathlib

from werkzeug.utils import secure_filename

app = Flask(__name__)

# this is the list of patch notes. just a normal list so add a , and write a new post
posts = [
    {
        'author': 'Joe Miley',
        'title': 'Patch post 1',
        'content': 'First post content',
        'date_posted': 'April 20, 2018'
    }
]

image_file_list = os.listdir(r"C:\Users\Rando\Desktop\coding\Hello-world\python\zzzz.flask stuff\images_uploaded")


@app.route("/")
@app.route("/home")
def home():
    return render_template('home.html', posts=posts)


@app.route("/about")
def about():
    return render_template('about.html', title='About')


@app.route("/successful_upload")
def successful_upload():

    return render_template('successful_upload.html', title='successful_upload')

app.config["IMAGE_UPLOADS"] = r"C:\Users\Rando\Desktop\coding\Hello-world\python\zzzz.flask stuff\images_uploaded"
app.config["ALLOWED_IMAGE_EXTENSIONS"] = ["PNG", "JPG", "JPEG", "GIF"]


def allowed_image(filename):
    if not "." in filename:
        return False
    ext = filename.rsplit(".", 1)[1]

    if ext.upper() in app.config["ALLOWED_IMAGE_EXTENSIONS"]:
        return True
    else:
        return False


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
            image.save(os.path.join(app.config["IMAGE_UPLOADS"], filename))
            print("image.saved")
            print(image)

            return redirect('successful_upload')

    return render_template('upload.html'
                           , title='upload image'
                           , len=len(image_file_list)
                           , image_file_list=image_file_list)


if __name__ == '__main__':
    app.run(debug=True)



