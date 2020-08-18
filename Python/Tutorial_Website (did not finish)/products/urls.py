from django.urls import path
# the . means its from the same folder
from . import views

# app starts at products but at the start it gets no info in path
# this page gives paths to new pages ie the "" is the home page and the "New" is the new products page
# this talks to the "views.py" file in the products folder
urlpatterns = [
    path("", views.index),
    path("new", views.new)
]
