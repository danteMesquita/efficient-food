import { AppPage } from './app.po';

describe('EfficientFood.UI App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display application title: EfficientFood.UI', async () => {
    await page.navigateTo();
    expect(await page.getAppTitle()).toEqual('EfficientFood.UI');
  });
});
