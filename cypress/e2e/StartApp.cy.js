describe('Application Started', () => {
    it('Has Application Started', () => {
      cy.log('Checking if application has started')
      cy.visit('www.princeokumo.com')
    })
  })