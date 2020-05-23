# MECH423 - Single String Musical Instrument

For the MECH423 final project, I and my partner, Juanes Bustamante, designed a single string musical instrument which consists of a soundboard, harp string and stepper motors to adjust the tension of and pluck the harp string. The video of the instrument in action under [final_project_video](https://github.com/rish01/MECH423_SingleStringMusicalInstrument/tree/master/final_project_video) folder. The final project report is located [here](https://github.com/rish01/MECH423_SingleStringMusicalInstrument/blob/master/report/Final_Project_Report.pdf).

<img src = "images/instrument.png" width=500>

## C# GUI
To play piano notes and/or jingle bells on the instrument, I designed a GUI using C#. The GUI connects to the TI board over UART through a COM port. The screenshot below shows the play tab of the GUI used to control the single string musical instrument.

<img src = "images/play_tab_screenshot.png" height=500>

The calibration tab, as shown below, is used to calibrate the stepper motor position to play the notes on one octave.

<img src = "images/calibration_tab_screenshot.png" height=500>

<br/>

## Firmware for MSP430FR5739
I wrote the [C firmware](https://github.com/rish01/MECH423_SingleStringMusicalInstrument/blob/master/Firmware_C/Firmware_MSP430.c) for MSP430FR5739 board to control two stepper motors (one for tensioning and one for plucking the string) by configuring digital pins’ interrupts to control Pololu stepper motor drivers, setting up two timers in up mode and their respective interrupt service routines to control motors’ speed, enabling UART communication between PC and MSP430, and using a queue to send and receive position bytes of the motor. 

The following electronic schematic shows how the microcontroller is connected to the Pololu stepper motor drivers:

<img src = "https://github.com/rish01/MECH423_SingleStringMusicalInstrument/blob/master/images/electronic_schematic.png">
