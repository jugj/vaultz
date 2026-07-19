print("1. Öffnungszeiten")
print("2. Kurse")

def öffnungszeiten():
    print("Öffnungszeiten: Mo-Fr 8:00 - 18:00")

def kurse():
    print("Gamejam, Naturwissenschaften")

while True:
    frage = input("Was möchtest du: ").lower()

    if "öffnungszeiten" in frage:
        öffnungszeiten()

    elif "kurse" in frage:
        kurse()

    elif "ende" in frage:
        print("OKAY PROGRAMM ENDE")
        break

    else:
        print("Dazu konnte ich keine Informationen finden")