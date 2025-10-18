from kivy.app import App
from kivy.uix.boxlayout import BoxLayout
from kivy.lang import Builder
from pathlib import Path
from database.db_manager import create_database

# Importar telas
from screens.dashboard import DashboardScreen
from screens.alunos import AlunosScreen
from screens.disciplinas import DisciplinasScreen
from screens.notas import NotasScreen

# Cria banco de dados
create_database()

# Carrega o arquivo principal .kv
kv_path = Path(__file__).parent / 'kv' / 'main.kv'
Builder.load_file(str(kv_path))

class MainLayout(BoxLayout):
    def change_screen(self, screen_name):
        self.ids.screen_manager.current = screen_name

class SistepedApp(App):
    def build(self):
        return MainLayout()

if __name__ == "__main__":
    SistepedApp().run()
