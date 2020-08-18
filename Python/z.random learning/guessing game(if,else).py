secret_number = 5
guess_counter = 0
guess_limit = 3

while guess_counter < guess_limit:

    guess = int(input("guess a number between 0 and 10: "))
    guess_counter += 1

    if guess == secret_number:
            print("you win !")
            break
    else:
        print("wrong guess.")
        if guess_counter == guess_limit:
            print("you loose")
            break
