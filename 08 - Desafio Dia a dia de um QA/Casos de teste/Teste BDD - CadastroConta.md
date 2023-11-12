Feature: Usuário necessita acessar a tela para fazer o cadastro de conta
    @TestCaseKey=NEW-T2
    Scenario: Usuário necessita acessar a tela para fazer o cadastro de conta
        
        Given que o cliente necessita fazer o cadastro
        And acessar a tela de cadastro e inserir seus dados
        When clicar em "Cadastrar"
        Then registra no banco de dados seus dados e redireciona para tela de Login