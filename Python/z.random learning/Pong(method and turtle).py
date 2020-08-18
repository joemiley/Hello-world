import turtle
import random

# asks turtle for the screen function it has pre-built
win = turtle.Screen()
# gives a title
win.title("Pong by Randombroom")
# chooses a back ground colour
win.bgcolor("black")
# set size of the screen
win.setup(width=800, height=600)
# tracer is how fast the screen updates
win.tracer(0)


# Paddle A
# creates a turtle object
paddle_a = turtle.Turtle()
# sets animation speed
paddle_a.speed(0)
# paddle shape
paddle_a.shape("square")
paddle_a.color("white")
paddle_a.shapesize(stretch_wid=5, stretch_len=1)
paddle_a.penup()
# co-ordinates start from the middle of the window
paddle_a.goto(-350, 0)


# Paddle B
# creates a turtle object
paddle_b = turtle.Turtle()
# sets animation speed
paddle_b.speed(0)
# paddle shape
paddle_b.shape("square")
paddle_b.color("white")
paddle_b.shapesize(stretch_wid=5, stretch_len=1)
paddle_b.penup()
# co-ordinates start from the middle of the window
paddle_b.goto(+350, 0)


# Ball
ball = turtle.Turtle()
ball.speed(0)
ball.shape("square")
ball.color("white")
# stops it from drawing a line after the ball
ball.penup()
ball.shapesize(stretch_len=10, stretch_wid=10)
ball.goto(random.randint(-150, 150), random.randint(-150, 150))
# dx and dy stand for different in x and different in y co-ordinates
ball.dx = 1
ball.dy = 1


# method to move the paddle
def paddle_a_up():
    y = paddle_a.ycor()
    if y == +240:
        y = +240
    else:
        y += 30
    paddle_a.sety(y)


# method
def paddle_a_down():
    y = paddle_a.ycor()
    if y == -270:
        y = -270
    else:
        y -= 30
    paddle_a.sety(y)


# method to move the paddle
def paddle_b_up():
    y = paddle_b.ycor()
    if y == +240:
        y = +240
    else:
        y += 30
    paddle_b.sety(y)


# method
def paddle_b_down():
    y = paddle_b.ycor()
    if y == -270:
        y = -270
    else:
        y -= 30
    paddle_b.sety(y)


# keyboard binding a button
# makes the window listen for a key stroke
# uses the paddle_a_up function when "W" is hit
win.listen()
win.onkeypress(paddle_a_up, "w")
win.onkeypress(paddle_a_down, "s")
# the up and down keys are just capitalised "Up" and "Down"
win.onkeypress(paddle_b_up, "Up")
win.onkeypress(paddle_b_down, "Down")

# main game loop
while True:
    # updates the screen to show the movement
    win.update()

    # moving the ball
    ball.sety(ball.ycor() + ball.dy)
    ball.setx(ball.xcor() + ball.dx)

    # checking for the boarder
    if ball.ycor() > 290:
        ball.sety(290)
        ball.dy *= -1

    if ball.ycor() < -283:
        ball.sety(-283)
        ball.dy *= -1

    if ball.xcor() > 390:
        ball.goto(0, 0)
        ball.dx *= -1

    if ball.xcor() < -390:
        ball.goto(0, 0)
        ball.dx *= -1

    # paddle and ball collide
    # paddle b
    if ball.xcor() > 330 and (ball.xcor() < 340) and (ball.ycor() < paddle_b.ycor() + 40) and (ball.ycor() > paddle_b.ycor() -50):
        ball.setx(330)
        ball.dx *= -1

    # paddle a
    if ball.xcor() < -330 and (ball.xcor() > -340) and (ball.ycor() < paddle_b.ycor() + 40) and (ball.ycor() > paddle_a.ycor() -50):
        ball.setx(-330)
        ball.dx *= -1
