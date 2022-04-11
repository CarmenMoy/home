import JustValidate from '../../node_modules/just-validate/dist/just-validate.es.js';

export let validator = (form) => {

    let validation = new JustValidate(form, {
        errorFieldCssClass: 'is-invalid',
        errorLabelStyle: {
            fontSize: '14px',
            color: '#dc3545',
        },
        focusInvalidField: true,
        lockForm: true,
        errosContainer: '#example11_errors-container',
    });

    validation
    .addField('#name', [
        {
        rule: 'minLength',
        value: 3,
        },
        {
        rule: 'maxLength',
        value: 30,
        },
    ])
    .addField('#lastname', [
        {
        rule: 'minLength',
        value: 3,
        },
        {
        rule: 'maxLength',
        value: 30,
        },
    ])
    .addField('#telephone', [
        {
        rule: 'minNumber',
        value: 8,
        },
        {
        rule: 'maxNumber',
        value: 10,
        },
    ])
    .addField('#email', [
        {
        rule: 'required',
        errorMessage: 'Email is required',
        },
        {
        rule: 'email',
        errorMessage: 'Email is invalid!',
        },
    ]);

    return validation;
};