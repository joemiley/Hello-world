print("Driving game!\n make it go, make it stop and ask for help")


car_start = "start"
car_stop = "stop"
help = "help"
unknown_command = "i don't understand that"

global_int = 0
start_int = 0
stop_int = 0
help_int = 0

while global_int <= 3:
    if global_int ==3:
        print("Congradulations you completed the game")
        break
    else:
        user_command = input()

        if user_command == car_start:
            if start_int == 0:
                start_int += 1
                global_int += 1
            print("Car started ... Ready to go")

        elif user_command == car_stop:
            if stop_int == 0:
                stop_int += 1
                global_int += 1
            print("Car has stopped")

        elif user_command == help:
            if help_int == 0:
                help_int += 1
                global_int += 1
            print(f"Commands: \n"
            f"{car_start}\n"
            f"{car_stop}\n"
            f"{help}")

        else:
            print(unknown_command)