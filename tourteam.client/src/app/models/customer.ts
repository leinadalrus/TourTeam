interface ICustomer {
  id: number
  nickname: string
}

class Permittor {
  producer: boolean = false // NOTE(Visitor): Visitor is the default rendering perspective.

  public GetMemberRole(): boolean {
    return this.producer
  }
}

export class Customer {
  public EndUsers: ICustomer[] = []

  public UserPermission: Permittor = new Permittor
}
