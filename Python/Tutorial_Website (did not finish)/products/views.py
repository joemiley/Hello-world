from django.shortcuts import HttpResponse
from django.shortcuts import render


# index is the home page name that developers use
# the request takes the url request and chooses what to output
def index(request):
    return HttpResponse("Hello World")


# this is the area that you define what shows up on each page when given the right path
# the request function takes the request for the word "new" from the products\urls.py
def new(request):
    return HttpResponse("New Products")


