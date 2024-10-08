import { Article } from './article';

describe('Article', () => {
  it('should create an instance', () => {
    expect(new Article(1, "Jon Doe", "Hello, world!")).toBeTruthy();
  });
});
