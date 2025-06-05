# 🎮 Plataforma2D - Anne Oliveira

Este projeto é um jogo de plataforma 2D desenvolvido na Unity, com o objetivo de demonstrar conhecimentos em desenvolvimento de jogos, lógica de programação, manipulação de áudio, HUD, transição de cenas e controle de vidas.

## 📌 Descrição

O jogo possui três fases com dificuldade crescente. O personagem principal deve coletar estrelas, evitar obstáculos (como espinhos) e alcançar o portal de saída para avançar de fase.

Durante a jornada, o jogador:

- Move-se lateralmente e salta obstáculos.
- Coleta estrelas que aumentam sua pontuação.
- Perde vidas ao encostar em obstáculos perigosos.
- Ouve efeitos sonoros ao pular, coletar ou sofrer dano.
- Visualiza o número de vidas restantes no canto superior da tela.

## 🎨 Funcionalidades

- 🎮 Movimento e pulo do personagem com animações.
- ⭐ Sistema de coleta de itens.
- 💔 Sistema de vidas.
- 🔁 Reinício de cena quando o jogador perde.
- ✅ Transição entre fases.
- 🎧 Sons de fundo, pulo, coleta e dano.
- 🏁 Tela de início com botão Jogar.
- 🎉 Tela de fim com mensagem de parabéns.
- 📱 Interface adaptada a diferentes resoluções (Canvas Scaler).

## 📂 Estrutura do Projeto

- `Assets/Scripts/`
  - `PlayerController.cs` - Controle do personagem.
  - `VidaManager.cs` - Gerencia vidas e reinício da fase.
  - `Collectable.cs` - Gerencia coleta de estrelas.
  - `Obstacle.cs` - Gerencia dano por colisão.
  - `Goal.cs` - Detecta chegada ao portal.
  - `MainMenu.cs` - Controla o menu inicial.
  - `FimController.cs` - Controla tela de finalização.
  - `MusicManager.cs` - Toca música de fundo.
  - `HUDController.cs` - Interface gráfica (vidas).

## 🚀 Como jogar

1. Use as setas ou teclas A/D para mover.
2. Pressione espaço para pular.
3. Colete todas as estrelas.
4. Evite obstáculos.
5. Alcance o portal para avançar de fase.

## 🛠️ Requisitos

- Unity 2021.3 ou superior.
- Git (para versionamento).
- Áudio e sprites incluídos em `Assets`.

## 📦 Como executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/AnneOliveiraGit/Plataforma2D-AnneOliveira.git
   ```
2. Abra o projeto com Unity.
3. Execute a cena `MainMenu`.

## 🗃️ Build

Versão exportada disponível no repositório (pasta ou `.zip`), contendo o arquivo `Plataforma2D_AnneOliveira.exe`.

## 👩‍💻 Autoria

Desenvolvido por **Anne Oliveira** como parte de um estudo de caso em desenvolvimento de jogos 2D.

---

💡 Dica: Para alterar sons, sprites ou fases, edite os respectivos objetos em cada cena e prefabs.
