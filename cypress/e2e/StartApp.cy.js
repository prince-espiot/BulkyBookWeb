describe('Application Started', () => {
    it('Has Application Started', () => {
      cy.log('Checking if application has started')
      cy.visit('http://localhost:5044/Home/Login')
    })
  })