window.onload = function() {
    const screenType = 'edit';

    if(screenType == 'create') {
        document.querySelector('#main-title').innerHTML = "Vamos cadastrar seu novo projeto!";
        document.querySelector('#action-button').innerHTML = "Cadastrar";
    }

    if(screenType == 'edit'){
        document.querySelector('#main-title').innerHTML = "Editar Projeto";
        document.querySelector('#action-button').innerHTML = "Salvar";
    }
}