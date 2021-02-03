from flask import Flask, redirect, url_for
import codecs

# get the app
app = Flask(__name__)

# load in and read the pages (html files)
homepage_code = codecs.open('home.html', 'r')
homepage = homepage_code.read()
aboutpage_code = codecs.open('about.html', 'r')
aboutpage = aboutpage_code.read()

# the extension of the page
@app.route("/")
@app.route("/home")
# defining a page
def home():
    # when called the page returns a string string with heading flags of html making the text larger
    return homepage


# adding the name extension to the url will show a different webpage with a welcome message
@app.route("/about")
def about():
    return aboutpage


# creating an admin page that redirects the user to the homepage
@app.route("/admin")
def admin():
    return redirect(url_for(home))


# running the app
if __name__ == "__main__":
    app.run(debug=True)
