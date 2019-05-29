FROM mcr.microsoft.com/windows:1809
# IMPORTANT! Build the PrintTest solution before creating the image 
COPY PrintTest/bin/Release/ /
CMD [ "powershell" ]