from kivy.uix.screenmanager import Screen
from kivy.lang import Builder
from pathlib import Path

# Carrega o kv da tela
Builder.load_file(str(Path(__file__).parent.parent / 'kv' / 'notas.kv'))

class NotasScreen(Screen):
    pass
