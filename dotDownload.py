from pynput import keyboard
from dotSetup import install
from clint.textui import progress
import time, os
import requests
import json

appversion = "v1"
appstable = "stable"

def download(host, filename):
    if (not os.path.isfile(filename)): 
        r = requests.get(host, stream=True)
        path = filename
        with open(path, 'wb') as f:
            tlength = int(r.headers.get('content-length'))
            for chunk in progress.bar(r.iter_content(chunk_size=1024), expected_size=(tlength/1024) +1):
                if chunk:
                    f.write(chunk) 
                    f.flush()
    else:
        print("File already exists, do you want to delete and redownload it? (y/N)")
        time.sleep(1)
        with keyboard.Events() as events:
            event = events.get(1e6)
            if (event.key) == keyboard.KeyCode.from_char('y'): os.remove(filename); download(host, filename); 
            else: exit()

print(" dotDownload | " + appversion + " | " + appstable + " | " )
metadataFile = input("Drag and drop metadata file here: "); f = open(metadataFile)
metadataParsed = json.load(f)
f.close()

print("\nLoaded file: " + metadataFile)
print(" Game title: " + metadataParsed["title"])
print(" Original Size: " + metadataParsed["originalsize"])
print(" Repack Size: " + metadataParsed["repacksize"])
print(" Setup type: " + metadataParsed["setup"])
print(" Other info: " + metadataParsed["comment"])

print("\nWhat to do?")
print(" i - install ")
print(" d - download ")
print(" q - exit\n")
time.sleep(1)
with keyboard.Events() as events:
    event = events.get(1e6)
    if (event.key) == keyboard.KeyCode.from_char('d'): download(metadataParsed["host"], metadataParsed["archivename"]); 
    if (event.key) == keyboard.KeyCode.from_char('i'): install(metadataParsed["setup"], metadataParsed["archivename"], metadataParsed["title"], metadataParsed["executable"]); 
    else: exit()



