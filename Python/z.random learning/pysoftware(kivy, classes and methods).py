import kivy
from kivy.app import App
# importing a label
from kivy.uix.label import Label
# importing a grid layout
from kivy.uix.gridlayout import GridLayout
# importing a text input Box
from kivy.uix.textinput import TextInput
# kivy dynamically designs and resizes parts for you

class MyGrid(GridLayout):
    # building a class
    def __init__(self, **kwargs):
        # class constructor
        super(MyGrid, self).__init__(**kwargs)
        # selecting the amount of columns
        self.cols = 4

        # adding a label and a text box
        self.add_widget(Label(text="First Name: "))
        self.firstName = TextInput(multiline=False)
        self.add_widget(self.firstName)

        # adding a label and a text box
        self.add_widget(Label(text="Last Name: "))
        self.lastName = TextInput(multiline=False)
        self.add_widget(self.lastName)

        # adding a label and a text box
        self.add_widget(Label(text="Email: "))
        self.email = TextInput(multiline=False)
        self.add_widget(self.email)


# building an instance of the class in python
class MyApp(App):
    def build(self):
        return MyGrid()


# how the app runs
if __name__ == "__main__":
    MyApp().run()