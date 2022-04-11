import '../../node_modules/@ckeditor/ckeditor5-build-classic/build/ckeditor.js';

export let renderCkeditor = () => {

    let ckeditors = document.querySelectorAll('.ckeditor');

    ckeditors.forEach(ckeditor => {
        ClassicEditor
        .create(ckeditor)
        .catch( error => {
            console.error( error );
        } );
    });
};