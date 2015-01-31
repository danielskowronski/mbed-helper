# mbed-helper
mbed helper is tool for facilitating deploying bin files from online development environment mbed.org to mbed-enabled boards (like STM32 NUCLEO-F401RE)

http://developer.mbed.org

### technology
C# .NET 4.0

### features
 + "flashing" .bin files to target device 
  + filename: from command line or file selector
  + target device: from dropdown list or by device name /path
 + restarting PuTTY (COM port and baudrate can be remembered by app)

### todo
 + smarter putty restarting (currently there is copy of exe file with different name to avoid killing ssh sessions etc.)
 + handling unexpected exceptions
 + real file copying progress
 + setup (with associating .bin files with app)

### current usability status
99% of working version coded; not yet packed for deployment
