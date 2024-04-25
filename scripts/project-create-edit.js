    //pegar parâmetros da url
    const urlSearchParams = new URLSearchParams(window.location.search);
    const params = Object.fromEntries(urlSearchParams.entries());

    const screenType = params.id ? 'edit' : 'create';

window.onload = function() {
    setScreenTypeTexts();
}

function setScreenTypeTexts(){
    if(screenType === 'create') {
        document.querySelector('#main-title').innerHTML = "Vamos cadastrar seu novo projeto!";
        document.querySelector('#action-button').innerHTML = "Cadastrar";
        document.querySelector('#title').innerHTML = "Cadastro - Dev Freela";
    }

    if(screenType === 'edit'){
        document.querySelector('#main-title').innerHTML = "Editar Projeto";
        document.querySelector('#action-button').innerHTML = "Salvar";
        document.querySelector('#title').innerHTML = "Edit - Dev Freela"
    }
}

function createOrEdit(){
    let payload = {
        title: document.querySelector('#title').value,
        totalCost: document.querySelector('#totalCost').value,
        description: document.querySelector('#description').value,
        idClient: "1"
    }

    fetch(`https://6628790554afcabd0735dba9.mockapi.io/api/projects${screenType === 'edit' ? ('/' + params.id) : ''}`, {
        method: screenType === 'edit' ? 'PUT' : 'POST',
        body: JSON.stringify(payload),
        headers: {
            'Content-Type' : 'application/json'
        }
    })
    .then(response => response.json())
    .then(response => {
        if(screenType === 'edit') {
            alert('Projeto atualizado com sucesso!');
        } else {
            alert('Projeto cadastrado com sucesso!');
        }
        
        console.log(response);
    })
    .catch(err => {
        alert('Ocorreu um erro inesperado!');
    })
}
