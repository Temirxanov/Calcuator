import tkinter as tk 
from tkinter import messagebox
import math

def on_click(button_text):
    if button_text == "=":
        try:
            expression = entry.get()
            result = eval(expression)  # Matematik ameldi esaplaydi
            entry.delete(0, tk.END)
            entry.insert(tk.END, str(result))
        except Exception as e:
            messagebox.showerror("Qatelik", "Naduris amel!")
    elif button_text == "C":
        entry.delete(0, tk.END)
    elif button_text == "√":
        try:
            num = float(entry.get())
            if num < 0:
                messagebox.showerror("Qatelik", "Minus sannin' koreni joq!")
                return
            result = math.sqrt(num)
            entry.delete(0, tk.END)
            entry.insert(tk.END, str(result))
        except ValueError:
            messagebox.showerror("Qatelik", "Iltimas, Duris san kirgizin' !")
    else:
        entry.insert(tk.END, button_text)

# Tkinter aynasini jaratiw
root = tk.Tk()
root.title("Kalkulyator")
root.geometry("300x400")

# Matn kiritish qutisi
entry = tk.Entry(root, width=20, font=("Arial", 18), justify="right")
entry.grid(row=0, column=0, columnspan=4, pady=10)

# Tuymeler 
buttons = [
    ("7", "8", "9", "/"),
    ("4", "5", "6", "*"),
    ("1", "2", "3", "-"),
    ("C", "0", "=", "+"),
    ("√", ".", "**", "Exit")
]

# Tuymelerdi jaylastiriw
for r, row in enumerate(buttons, start=1):
    for c, button_text in enumerate(row):
        btn = tk.Button(root, text=button_text, font=("Arial", 14), width=5, height=2,
                        command=lambda b=button_text: on_click(b))
        btn.grid(row=r, column=c, padx=5, pady=5)

# Dasturden shigiw
def exit_program():
    root.destroy()

# "Exit" tuymesin jaratiw
exit_button = tk.Button(root, text="Exit", font=("Arial", 14), width=5, height=2, command=exit_program)
exit_button.grid(row=5, column=3, padx=5, pady=5)

# Iske tusiriw
root.mainloop()