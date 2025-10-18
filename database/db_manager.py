import sqlite3
import os

DB_PATH = os.path.join(os.path.dirname(__file__), "sisteped.db")
os.makedirs(os.path.dirname(DB_PATH), exist_ok=True)

def create_database():
    """Cria o banco e tabelas iniciais."""
    conn = sqlite3.connect(DB_PATH)
    cursor = conn.cursor()

    # Tabela de usuários
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS usuarios (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT NOT NULL,
        email TEXT UNIQUE NOT NULL,
        senha TEXT NOT NULL,
        tipo TEXT NOT NULL CHECK(tipo IN ('professor', 'administrador'))
    )
    """)

    # Tabela de alunos
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS alunos (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT NOT NULL,
        turma TEXT
    )
    """)

    # Tabela de disciplinas
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS disciplinas (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        nome TEXT NOT NULL
    )
    """)

    # Tabela de notas
    cursor.execute("""
    CREATE TABLE IF NOT EXISTS notas (
        id INTEGER PRIMARY KEY AUTOINCREMENT,
        aluno_id INTEGER NOT NULL,
        disciplina_id INTEGER NOT NULL,
        nota REAL,
        FOREIGN KEY(aluno_id) REFERENCES alunos(id),
        FOREIGN KEY(disciplina_id) REFERENCES disciplinas(id)
    )
    """)

    conn.commit()
    conn.close()
    print(f"Banco criado ou atualizado em: {DB_PATH}")
