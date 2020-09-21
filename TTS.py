# -*- coding: utf-8 -*-
from gtts import gTTS 
from pydub import AudioSegment
from pydub import effects
from io import BytesIO
#from flask import Flask

import os
import sys

strText = sys.argv[1]
strLanguage = sys.argv[2]
nSampleRate = sys.argv[3]
dSpeedRate = sys.argv[4]
strFilePath = sys.argv[5]
strFileName = sys.argv[6]
nListenSpeech = sys.argv[7]

myobj = gTTS(text=strText, lang=strLanguage, slow=False) 

if not os.path.exists(strFilePath):
    os.makedirs(strFilePath)

#mp3_fp = BytesIO()
#myobj.write_to_fp(mp3_fp)
# Saving the converted audio in a mp3 file named 
myobj.save(strFilePath + "\\" + strFileName + ".mp3") 

sound = AudioSegment.from_file(strFilePath + "\\" + strFileName + ".mp3")

if float(dSpeedRate) > 1.0:
    sound = effects.speedup(sound, float(dSpeedRate))

sound = sound._spawn(sound.raw_data, overrides={'frame_rate': int(nSampleRate)})

sound.export(strFilePath + "\\" + strFileName + ".mp3", format="mp3", bitrate="48k")
  
# Playing the converted file
if nListenSpeech == "1":
    os.system('"' + strFilePath + "\\" + strFileName + ".mp3" + '"')
