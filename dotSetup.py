from clint.textui import puts, colored, prompt, validators
import time, os


def install(stype, filename, gname, gexec):
    if not os.path.exists(filename):
        print("You must download game archive! select d after selecting metadata!")

    if (stype) == 'unpack': 
        puts('Installing using: ' + colored.red('unpack')); time.sleep(0.2)
        outpath = prompt.query('Installation Path ( no spaces )', default='C:\dotGames\\'+filename.replace('.arc', ''))
        if (not os.path.exists(outpath)):
            os.makedirs(outpath)
        unpack(filename, outpath)
        postInstall(gname, gexec, outpath)
        time.sleep(3)

    if (stype) == 'dotSetup': print("not implemented")

def unpack(filename, outpath): 
    print("\n")
    os.system('arc.exe x -o+ '+ filename + ' --yes --display --diskpath' + outpath.replace(' ', '') )
    
def postInstall(gname, gexec, outpath):
    puts("\n " + colored.green("Creating Desktop Shortcuts"))

    desktop = "%userprofile%\Desktop\\"
    d2 = '"'+desktop+gname+'" '
    os.system('mklink ' +d2 + outpath + '\\' + gexec)
    