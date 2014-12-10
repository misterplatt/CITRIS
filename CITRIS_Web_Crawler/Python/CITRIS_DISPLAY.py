import webbrowser
import time

while(True):
	websites = open("websiteList.txt", "r")
	for website in websites:
		webbrowser.open(website)
		time.sleep(30)
	websites.close()