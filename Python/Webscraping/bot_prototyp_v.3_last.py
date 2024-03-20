#(import von den Bibliotheken [BeautifulSoup, requests, payautogui, pyperclip, time])
#_____________________
from bs4 import BeautifulSoup
import requests
import pyautogui as pg
import pyperclip as pc
import time as t

#(Variable Deklaration)
#______________________________________
url = ""
headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36'}

title = 0
chpz = 0
serie = ""
limit = 5
menge = 3
zeit = 0
'''

weblist = [
["dns-prefetch next preconnect prefetch prerender", "block story shortstory"],
["", ""],
["", ""]
]
'''
#
# (Funktions Deklaration)
#__________________________________________
class difsite:
    def other_buttons(b):
        xa = b.left
        ya = b.top
        pg.moveTo(xa+25, ya+25, zeit)
        pg.click()

    def nextlink(soup):
        next_url = str(soup.find("a", rel="dns-prefetch next preconnect prefetch prerender"))# rel= weblist[0, 0]
        index = next_url.find("href")
        index2 = next_url[index+6:].find('"')
        next_url2 = next_url[index+6:]
        url = next_url2[:index2]
        return url

    def searchText(soup):
        content = soup.find("div", class_="block story shortstory")# class_=weblist[0, 1]
        content = str(BeautifulSoup(content.text, "html.parser"))
        return content[:-16]
    
    def nextlink_novelbin(soup):
        next_url = str(soup.find("a", id="next_chap"))
        index = next_url.find("href")
        index2 = next_url[index+6:].find('"')
        next_url2 = next_url[index+6:]
        url = next_url2[:index2]
        return url
    
    def searchText_novelbin(soup):
        content = soup.find("div", class_="chr-c")
        content = str(BeautifulSoup(content.text, "html.parser"))
        return content
    
a = [[difsite.nextlink, difsite.searchText],[difsite.nextlink_novelbin, difsite.searchText_novelbin]]

#()
#_______________________________________________
    
print("start")

eingabe = int(input("wähle 0 für r und 1 für nvb:"))
e1 = 1
e2 = 0
for x in range(menge):
    response = requests.get(url, headers=headers)
    if chpz == 0:
        t.sleep(0.25)
        pg.moveTo(135, 320, zeit)#maus geht zu "Title Here"
        pg.click()
        bisttitle = title + limit - 1
        pc.copy(f"Chapter: {title}-{bisttitle}")
        pg.hotkey("ctrl", "v")
        pg.moveTo(170, 400, zeit)#maus geht zu "Kontent"
        pg.click()
    pg.hotkey("enter")
    _ = "_" * 106
    pc.copy(_)
    pg.hotkey("ctrl", "v")
    pg.hotkey("enter")
    s = f"next chapter of {serie}"
    pc.copy(s)
    pg.hotkey("ctrl", "v")
    pg.hotkey("enter")
    soup = BeautifulSoup(response.text, "lxml")
    f = a[eingabe][e1]
    c = f(soup)
    pc.copy(c)
    pg.hotkey("ctrl", "v")
    fu = a[eingabe][e2]
    url = fu(soup)
    chpz += 1
    if chpz == limit:
        chpz = 0
        for d in range(10):
            publish_button = pg.locateOnScreen(r"C:\Users\ziyul\Pictures\Saved Pictures\publish button.png", confidence=0.9, grayscale=True)
            if publish_button != None:
                difsite.other_buttons(publish_button)
                break
        for d in range(10):
            confirm_button = pg.locateOnScreen(r"C:\Users\ziyul\Pictures\Saved Pictures\confirm button.png", confidence=0.9, grayscale=True)
            if confirm_button != None:
                difsite.other_buttons(confirm_button)
                if x+1 == menge:
                    exit(1)
                break
        for d in range(10):
            create_chapter_button = pg.locateOnScreen(r"C:\Users\ziyul\Pictures\Saved Pictures\create chapter.png", confidence=0.9, grayscale=True)
            if create_chapter_button != None:
                difsite.other_buttons(create_chapter_button)
                title = bisttitle + 1 
                break
print("Script End")