//Lista das palavras do jogo
const listaPalavras = ["javascript","html","css","youtube","python","java"];

let palavraEscolhida;
let exibiçãoPalavra;
let letrasChutadas;
let tentativasRestantes;
let numeroErros; 


//Função para iniciar jogo
function iniciarJogo(){
    //Escolher uma palavra aleatória da lista
    palavraEscolhida = listaPalavras[Math.floor(Math.random()*listaPalavras.length)];
    console.log(palavraEscolhida);

    //Inicializar a exibição com os UNDERSCORES
    exibiçãoPalavra = Array(palavraEscolhida.length).fill("_");
    console.log(exibiçãoPalavra);

    window.load=iniciarJogo();


    //Inicializar as variáveis
    letrasChutadas = [];
    tentativasRestantes = 6;
    numeroErros = 0;
}
