import pyautogui as p
import time as t
import keyboard as k
sp = 270 #start_position
cT = 0 # click_time
time = 0
bk = 8
tt = 0
buttons_x_axis = [1565,1790,1690,1560,1690,1635,280]
buttons_y_axis = [230,220,265,205,265,215,420]
print("Script Start")
while True:
    t.sleep(0.1)
    if k.is_pressed("s"):#starten
        while True:
            p.click(clicks=10**2, interval=10**-3)
            if k.is_pressed("g"):
                p.moveTo(280, 420)
                while True: 
                    #p.click(clicks=10**2, interval=10**-3)
                    x, y = p.position()
                    if x != 280 and y != 420:
                        t.sleep(0.25)
                        p.moveTo(280, 420)
                        t.sleep(0.25)
                        while True:
                            p.click(clicks=10**2, interval=10**-3)
                            if k.is_pressed("b"):
                                break
                    if k.is_pressed("r"):
                        for x, y in enumerate(range(7)):
                            p.moveTo(buttons_x_axis[x],buttons_y_axis[x])
                            t.sleep(0.25)
                            p.click()
                        for x in range(10):
                            p.click(clicks=400, interval=10**-3)
                            if k.is_pressed("b"):
                                break
                            x, y = p.position()
                            if x != 280 and y != 420:
                                t.sleep(0.25)
                                p.moveTo(280, 420)
                                t.sleep(0.25)
                    if k.is_pressed("b"):
                            break
            if k.is_pressed("Esc"):
                break
    if k.is_pressed("e"):
        break
print("Script End")