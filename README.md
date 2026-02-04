
🚀 Distribuidora API - Engenharia de Alta Disponibilidade Interna
Este projeto é um motor de backend desenvolvido para cenários de alta carga operacional interna (PDV, Gestão de Estoque e Logística). Diferente de APIs web convencionais, o foco aqui é a baixa latência e a consistência transacional em operações complexas de inventário.



⚙️ Diferenciais de Engenharia (Escala Interna)
1. Arquitetura voltada para PDV (Ponto de Venda)
O sistema foi desenhado para suportar o fluxo intenso de faturamento e movimentação de estoque, onde cada milissegundo conta.

Otimização de IO: Redução de round-trips entre aplicação e banco de dados.

Bulk Operations (Processamento em Lote): Em vez de processar item por item, o sistema utiliza padrões de inserção massiva para marcas, categorias e produtos, essencial para importações de notas fiscais e atualizações de inventário.


2. Padrões de Projeto para Robustez
Factory Pattern: Implementado para a criação complexa de entidades (Marcas, Categorias, Preços), garantindo que os objetos nasçam com o estado válido e respeitando as regras de negócio.

Unit of Work & Repository: Garante a atomicidade das vendas. Ou o estoque baixa e a venda registra simultaneamente, ou nada acontece. Zero risco de "estoque fantasma".

Value Objects (Objetos de Valor): Tratamento rigoroso de moedas e medidas, evitando erros de arredondamento em cálculos financeiros de grande escala.


3. Foco em UX de Backend
Como o sistema é voltado para uso rápido, a estrutura de dados foi pensada para alimentar interfaces de alta performance (WinForms/Desktop):

DTOs Especializados: Entrega apenas o necessário para a tela, reduzindo o tráfego de rede interna.

Mapeamento Otimizado: Uso de AutoMapper para conversões rápidas de entidades de persistência para modelos de visualização.


4. Gestão de Estado e Sessão
User Session Management: Estrutura preparada para persistência de sessão em terminais locais, mantendo o operador logado com segurança e eficiência.

Tratamento de Erros Global: Middleware especializado que traduz falhas técnicas em mensagens claras para o operador de ponta, sem expor a infraestrutura.


📡 Stack Técnica
Linguagem: C# (.NET 8)

ORM: Entity Framework Core (SQL Server)

Logs: Serilog (Audit Trail de operações)

Arquitetura: Layered Architecture com foco em Domain Services.
