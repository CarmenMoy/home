export let renderForm = () => {

    let sendButton = document.getElementById('send-button');
    let forms = document.querySelectorAll('.front-form');

    if(sendButton){

        sendButton.addEventListener("click", (event) => {

            event.preventDefault();

            forms.forEach( form => {

                let formData = new FormData(form);

                for (let entradas of formData.entries()) {
                    console.log(entradas[0]+ ': ' + entradas[1]); 
                }
            });
        });
    }
}