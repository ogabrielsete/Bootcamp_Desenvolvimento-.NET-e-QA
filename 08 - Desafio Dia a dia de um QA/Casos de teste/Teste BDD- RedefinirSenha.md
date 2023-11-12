Feature: Redefinir Senha
    @TestCaseKey=NEW-T4
    Scenario: Redefinir Senha
        
        Given o cliente esteja na tela de Redefinição de Senha
            
            And insira um e-mail cadastrado no sistema
            
            When clicar em "Redefinir Senha"
            
            Then informar que o email de redefinição de senha foi enviado para conta vinculada àquele e-mail