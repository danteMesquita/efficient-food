# efficient-food
Repo for efficient food 

# Adicionar chave ssh
[ ] - Abra o git bash
[ ] - Cole o trecho
    ssh-keygen -t ed25519 -C "dante.neto@groove.tech"
[ ] - Aperte enter para o local da chave para usar o padrao.
[ ] - Digite a frase segura.
[ ] -Anote o caminho que foi salvo sua chave
    /c/Users/usuario/.ssh/id_ed25519
    /c/Users/usuario/.ssh/id_ed25519.pub

[ ] - Adicione a chave ssh ao agent
    [ ] - Garanta que ele está rodando com o cmando: 
    eval "$(ssh-agent -s)" // Return agent pid
    [ ] - Adicione a chave ao agent com o caminho anotado anteriormente: