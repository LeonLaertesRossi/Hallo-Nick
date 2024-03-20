import pyautogui as p 
import time as t
import keyboard
y = 200
zauber = 450
var = 0
time = 1
while True:
    t.sleep(0.1)
    if keyboard.is_pressed("s"):
        while True:
            p.click(clicks=10**2, interval=0.001)
            var += 20
            if var == None:
                for x in range(1):
                    p.moveTo(1550,zauber)
                    p.click(clicks=1)
                    zauber += 50
                p.moveTo(1000, 400)
                zauber = 450
            if var == 600:
                p.moveTo(50,375)
                p.click()
                p.moveTo(300,95)
                p.click()
                p.moveTo(50,375)
                p.click() 
                for x in range(11):
                    p.moveTo(1750, y)
                    p.click()                    
                    y += 60                    
                    if x == 10:
                        y = 200
                        var = 0
                        p.moveTo(1000,400)
            if keyboard.is_pressed("Esc"):
                break
    if keyboard.is_pressed("e"):
         break
print("Script End")